using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StoryLineTrialAvatarChangeScNotify : IMessage<StoryLineTrialAvatarChangeScNotify>, IMessage, IEquatable<StoryLineTrialAvatarChangeScNotify>, IDeepCloneable<StoryLineTrialAvatarChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<StoryLineTrialAvatarChangeScNotify> _parser = new MessageParser<StoryLineTrialAvatarChangeScNotify>(() => new StoryLineTrialAvatarChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int OMNHJDBLFNKFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_oMNHJDBLFNK_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> oMNHJDBLFNK_ = new RepeatedField<uint>();

	public const int OCAKFNFEPCOFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_oCAKFNFEPCO_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> oCAKFNFEPCO_ = new RepeatedField<uint>();

	public const int BPJLLBDDNDMFieldNumber = 10;

	private bool bPJLLBDDNDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StoryLineTrialAvatarChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StoryLineTrialAvatarChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OMNHJDBLFNK => oMNHJDBLFNK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OCAKFNFEPCO => oCAKFNFEPCO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BPJLLBDDNDM
	{
		get
		{
			return bPJLLBDDNDM_;
		}
		set
		{
			bPJLLBDDNDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLineTrialAvatarChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLineTrialAvatarChangeScNotify(StoryLineTrialAvatarChangeScNotify other)
		: this()
	{
		oMNHJDBLFNK_ = other.oMNHJDBLFNK_.Clone();
		oCAKFNFEPCO_ = other.oCAKFNFEPCO_.Clone();
		bPJLLBDDNDM_ = other.bPJLLBDDNDM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLineTrialAvatarChangeScNotify Clone()
	{
		return new StoryLineTrialAvatarChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StoryLineTrialAvatarChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StoryLineTrialAvatarChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oMNHJDBLFNK_.Equals(other.oMNHJDBLFNK_))
		{
			return false;
		}
		if (!oCAKFNFEPCO_.Equals(other.oCAKFNFEPCO_))
		{
			return false;
		}
		if (BPJLLBDDNDM != other.BPJLLBDDNDM)
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
		num ^= oMNHJDBLFNK_.GetHashCode();
		num ^= oCAKFNFEPCO_.GetHashCode();
		if (BPJLLBDDNDM)
		{
			num ^= BPJLLBDDNDM.GetHashCode();
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
		oMNHJDBLFNK_.WriteTo(ref output, _repeated_oMNHJDBLFNK_codec);
		oCAKFNFEPCO_.WriteTo(ref output, _repeated_oCAKFNFEPCO_codec);
		if (BPJLLBDDNDM)
		{
			output.WriteRawTag(80);
			output.WriteBool(BPJLLBDDNDM);
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
		num += oMNHJDBLFNK_.CalculateSize(_repeated_oMNHJDBLFNK_codec);
		num += oCAKFNFEPCO_.CalculateSize(_repeated_oCAKFNFEPCO_codec);
		if (BPJLLBDDNDM)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StoryLineTrialAvatarChangeScNotify other)
	{
		if (other != null)
		{
			oMNHJDBLFNK_.Add(other.oMNHJDBLFNK_);
			oCAKFNFEPCO_.Add(other.oCAKFNFEPCO_);
			if (other.BPJLLBDDNDM)
			{
				BPJLLBDDNDM = other.BPJLLBDDNDM;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 24u:
			case 26u:
				oMNHJDBLFNK_.AddEntriesFrom(ref input, _repeated_oMNHJDBLFNK_codec);
				break;
			case 72u:
			case 74u:
				oCAKFNFEPCO_.AddEntriesFrom(ref input, _repeated_oCAKFNFEPCO_codec);
				break;
			case 80u:
				BPJLLBDDNDM = input.ReadBool();
				break;
			}
		}
	}
}
