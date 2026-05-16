using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OPOACMLCGAH : IMessage<OPOACMLCGAH>, IMessage, IEquatable<OPOACMLCGAH>, IDeepCloneable<OPOACMLCGAH>, IBufferMessage
{
	private static readonly MessageParser<OPOACMLCGAH> _parser = new MessageParser<OPOACMLCGAH>(() => new OPOACMLCGAH());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int LFIMIHLOLNBFieldNumber = 6;

	private ByteString lFIMIHLOLNB_ = ByteString.Empty;

	public const int LAHAIAIKPJNFieldNumber = 15;

	private uint lAHAIAIKPJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OPOACMLCGAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OPOACMLCGAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ByteString LFIMIHLOLNB
	{
		get
		{
			return lFIMIHLOLNB_;
		}
		set
		{
			lFIMIHLOLNB_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LAHAIAIKPJN
	{
		get
		{
			return lAHAIAIKPJN_;
		}
		set
		{
			lAHAIAIKPJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPOACMLCGAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPOACMLCGAH(OPOACMLCGAH other)
		: this()
	{
		retcode_ = other.retcode_;
		lFIMIHLOLNB_ = other.lFIMIHLOLNB_;
		lAHAIAIKPJN_ = other.lAHAIAIKPJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPOACMLCGAH Clone()
	{
		return new OPOACMLCGAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OPOACMLCGAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OPOACMLCGAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (LFIMIHLOLNB != other.LFIMIHLOLNB)
		{
			return false;
		}
		if (LAHAIAIKPJN != other.LAHAIAIKPJN)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (LFIMIHLOLNB.Length != 0)
		{
			num ^= LFIMIHLOLNB.GetHashCode();
		}
		if (LAHAIAIKPJN != 0)
		{
			num ^= LAHAIAIKPJN.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (LFIMIHLOLNB.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteBytes(LFIMIHLOLNB);
		}
		if (LAHAIAIKPJN != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LAHAIAIKPJN);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (LFIMIHLOLNB.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(LFIMIHLOLNB);
		}
		if (LAHAIAIKPJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LAHAIAIKPJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OPOACMLCGAH other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.LFIMIHLOLNB.Length != 0)
			{
				LFIMIHLOLNB = other.LFIMIHLOLNB;
			}
			if (other.LAHAIAIKPJN != 0)
			{
				LAHAIAIKPJN = other.LAHAIAIKPJN;
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				LFIMIHLOLNB = input.ReadBytes();
				break;
			case 120u:
				LAHAIAIKPJN = input.ReadUInt32();
				break;
			}
		}
	}
}
