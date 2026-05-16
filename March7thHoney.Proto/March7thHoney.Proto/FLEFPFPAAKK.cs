using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FLEFPFPAAKK : IMessage<FLEFPFPAAKK>, IMessage, IEquatable<FLEFPFPAAKK>, IDeepCloneable<FLEFPFPAAKK>, IBufferMessage
{
	private static readonly MessageParser<FLEFPFPAAKK> _parser = new MessageParser<FLEFPFPAAKK>(() => new FLEFPFPAAKK());

	private UnknownFieldSet _unknownFields;

	public const int LAHAIAIKPJNFieldNumber = 10;

	private uint lAHAIAIKPJN_;

	public const int LFIMIHLOLNBFieldNumber = 13;

	private ByteString lFIMIHLOLNB_ = ByteString.Empty;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FLEFPFPAAKK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FLEFPFPAAKKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FLEFPFPAAKK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLEFPFPAAKK(FLEFPFPAAKK other)
		: this()
	{
		lAHAIAIKPJN_ = other.lAHAIAIKPJN_;
		lFIMIHLOLNB_ = other.lFIMIHLOLNB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLEFPFPAAKK Clone()
	{
		return new FLEFPFPAAKK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FLEFPFPAAKK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FLEFPFPAAKK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LAHAIAIKPJN != other.LAHAIAIKPJN)
		{
			return false;
		}
		if (LFIMIHLOLNB != other.LFIMIHLOLNB)
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
		if (LAHAIAIKPJN != 0)
		{
			num ^= LAHAIAIKPJN.GetHashCode();
		}
		if (LFIMIHLOLNB.Length != 0)
		{
			num ^= LFIMIHLOLNB.GetHashCode();
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
		if (LAHAIAIKPJN != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LAHAIAIKPJN);
		}
		if (LFIMIHLOLNB.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteBytes(LFIMIHLOLNB);
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
		if (LAHAIAIKPJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LAHAIAIKPJN);
		}
		if (LFIMIHLOLNB.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(LFIMIHLOLNB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FLEFPFPAAKK other)
	{
		if (other != null)
		{
			if (other.LAHAIAIKPJN != 0)
			{
				LAHAIAIKPJN = other.LAHAIAIKPJN;
			}
			if (other.LFIMIHLOLNB.Length != 0)
			{
				LFIMIHLOLNB = other.LFIMIHLOLNB;
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
			case 80u:
				LAHAIAIKPJN = input.ReadUInt32();
				break;
			case 106u:
				LFIMIHLOLNB = input.ReadBytes();
				break;
			}
		}
	}
}
