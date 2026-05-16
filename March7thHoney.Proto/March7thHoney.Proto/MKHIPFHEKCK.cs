using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MKHIPFHEKCK : IMessage<MKHIPFHEKCK>, IMessage, IEquatable<MKHIPFHEKCK>, IDeepCloneable<MKHIPFHEKCK>, IBufferMessage
{
	private static readonly MessageParser<MKHIPFHEKCK> _parser = new MessageParser<MKHIPFHEKCK>(() => new MKHIPFHEKCK());

	private UnknownFieldSet _unknownFields;

	public const int MFBDMLPDEOEFieldNumber = 5;

	private uint mFBDMLPDEOE_;

	public const int PlayerInfoFieldNumber = 14;

	private static readonly FieldCodec<OEBJBPNNOKO> _repeated_playerInfo_codec = FieldCodec.ForMessage(114u, OEBJBPNNOKO.Parser);

	private readonly RepeatedField<OEBJBPNNOKO> playerInfo_ = new RepeatedField<OEBJBPNNOKO>();

	public const int DFJBNHPAICAFieldNumber = 1894;

	private GFOIOIACDCH dFJBNHPAICA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MKHIPFHEKCK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MKHIPFHEKCKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFBDMLPDEOE
	{
		get
		{
			return mFBDMLPDEOE_;
		}
		set
		{
			mFBDMLPDEOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OEBJBPNNOKO> PlayerInfo => playerInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFOIOIACDCH DFJBNHPAICA
	{
		get
		{
			return dFJBNHPAICA_;
		}
		set
		{
			dFJBNHPAICA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKHIPFHEKCK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKHIPFHEKCK(MKHIPFHEKCK other)
		: this()
	{
		mFBDMLPDEOE_ = other.mFBDMLPDEOE_;
		playerInfo_ = other.playerInfo_.Clone();
		dFJBNHPAICA_ = ((other.dFJBNHPAICA_ != null) ? other.dFJBNHPAICA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKHIPFHEKCK Clone()
	{
		return new MKHIPFHEKCK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MKHIPFHEKCK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MKHIPFHEKCK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MFBDMLPDEOE != other.MFBDMLPDEOE)
		{
			return false;
		}
		if (!playerInfo_.Equals(other.playerInfo_))
		{
			return false;
		}
		if (!object.Equals(DFJBNHPAICA, other.DFJBNHPAICA))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (MFBDMLPDEOE != 0)
		{
			num ^= MFBDMLPDEOE.GetHashCode();
		}
		num ^= playerInfo_.GetHashCode();
		if (dFJBNHPAICA_ != null)
		{
			num ^= DFJBNHPAICA.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (MFBDMLPDEOE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MFBDMLPDEOE);
		}
		playerInfo_.WriteTo(ref output, _repeated_playerInfo_codec);
		if (dFJBNHPAICA_ != null)
		{
			output.WriteRawTag(178, 118);
			output.WriteMessage(DFJBNHPAICA);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (MFBDMLPDEOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFBDMLPDEOE);
		}
		num += playerInfo_.CalculateSize(_repeated_playerInfo_codec);
		if (dFJBNHPAICA_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DFJBNHPAICA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MKHIPFHEKCK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MFBDMLPDEOE != 0)
		{
			MFBDMLPDEOE = other.MFBDMLPDEOE;
		}
		playerInfo_.Add(other.playerInfo_);
		if (other.dFJBNHPAICA_ != null)
		{
			if (dFJBNHPAICA_ == null)
			{
				DFJBNHPAICA = new GFOIOIACDCH();
			}
			DFJBNHPAICA.MergeFrom(other.DFJBNHPAICA);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 40u:
				MFBDMLPDEOE = input.ReadUInt32();
				break;
			case 114u:
				playerInfo_.AddEntriesFrom(ref input, _repeated_playerInfo_codec);
				break;
			case 15154u:
				if (dFJBNHPAICA_ == null)
				{
					DFJBNHPAICA = new GFOIOIACDCH();
				}
				input.ReadMessage(DFJBNHPAICA);
				break;
			}
		}
	}
}
