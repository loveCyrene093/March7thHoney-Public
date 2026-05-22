using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OHMFECJNLEG : IMessage<OHMFECJNLEG>, IMessage, IEquatable<OHMFECJNLEG>, IDeepCloneable<OHMFECJNLEG>, IBufferMessage
{
	private static readonly MessageParser<OHMFECJNLEG> _parser = new MessageParser<OHMFECJNLEG>(() => new OHMFECJNLEG());

	private UnknownFieldSet _unknownFields;

	public const int EOGMIHEPCGMFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_eOGMIHEPCGM_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> eOGMIHEPCGM_ = new RepeatedField<uint>();

	public const int BFMNAKCPGNNFieldNumber = 3;

	private static readonly FieldCodec<ENDOLEJCHKP> _repeated_bFMNAKCPGNN_codec = FieldCodec.ForMessage(26u, ENDOLEJCHKP.Parser);

	private readonly RepeatedField<ENDOLEJCHKP> bFMNAKCPGNN_ = new RepeatedField<ENDOLEJCHKP>();

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OHMFECJNLEG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OHMFECJNLEGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EOGMIHEPCGM => eOGMIHEPCGM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ENDOLEJCHKP> BFMNAKCPGNN => bFMNAKCPGNN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHMFECJNLEG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHMFECJNLEG(OHMFECJNLEG other)
		: this()
	{
		eOGMIHEPCGM_ = other.eOGMIHEPCGM_.Clone();
		bFMNAKCPGNN_ = other.bFMNAKCPGNN_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHMFECJNLEG Clone()
	{
		return new OHMFECJNLEG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OHMFECJNLEG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OHMFECJNLEG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eOGMIHEPCGM_.Equals(other.eOGMIHEPCGM_))
		{
			return false;
		}
		if (!bFMNAKCPGNN_.Equals(other.bFMNAKCPGNN_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= eOGMIHEPCGM_.GetHashCode();
		num ^= bFMNAKCPGNN_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		eOGMIHEPCGM_.WriteTo(ref output, _repeated_eOGMIHEPCGM_codec);
		bFMNAKCPGNN_.WriteTo(ref output, _repeated_bFMNAKCPGNN_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
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
		num += eOGMIHEPCGM_.CalculateSize(_repeated_eOGMIHEPCGM_codec);
		num += bFMNAKCPGNN_.CalculateSize(_repeated_bFMNAKCPGNN_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OHMFECJNLEG other)
	{
		if (other != null)
		{
			eOGMIHEPCGM_.Add(other.eOGMIHEPCGM_);
			bFMNAKCPGNN_.Add(other.bFMNAKCPGNN_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 16u:
			case 18u:
				eOGMIHEPCGM_.AddEntriesFrom(ref input, _repeated_eOGMIHEPCGM_codec);
				break;
			case 26u:
				bFMNAKCPGNN_.AddEntriesFrom(ref input, _repeated_bFMNAKCPGNN_codec);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
