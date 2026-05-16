using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GPEJGPJNECF : IMessage<GPEJGPJNECF>, IMessage, IEquatable<GPEJGPJNECF>, IDeepCloneable<GPEJGPJNECF>, IBufferMessage
{
	private static readonly MessageParser<GPEJGPJNECF> _parser = new MessageParser<GPEJGPJNECF>(() => new GPEJGPJNECF());

	private UnknownFieldSet _unknownFields;

	public const int CNIKGMAICAFFieldNumber = 4;

	private uint cNIKGMAICAF_;

	public const int JCCAJFPAJJPFieldNumber = 5;

	private uint jCCAJFPAJJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GPEJGPJNECF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GPEJGPJNECFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CNIKGMAICAF
	{
		get
		{
			return cNIKGMAICAF_;
		}
		set
		{
			cNIKGMAICAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JCCAJFPAJJP
	{
		get
		{
			return jCCAJFPAJJP_;
		}
		set
		{
			jCCAJFPAJJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPEJGPJNECF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPEJGPJNECF(GPEJGPJNECF other)
		: this()
	{
		cNIKGMAICAF_ = other.cNIKGMAICAF_;
		jCCAJFPAJJP_ = other.jCCAJFPAJJP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPEJGPJNECF Clone()
	{
		return new GPEJGPJNECF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GPEJGPJNECF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GPEJGPJNECF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CNIKGMAICAF != other.CNIKGMAICAF)
		{
			return false;
		}
		if (JCCAJFPAJJP != other.JCCAJFPAJJP)
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
		if (CNIKGMAICAF != 0)
		{
			num ^= CNIKGMAICAF.GetHashCode();
		}
		if (JCCAJFPAJJP != 0)
		{
			num ^= JCCAJFPAJJP.GetHashCode();
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
		if (CNIKGMAICAF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CNIKGMAICAF);
		}
		if (JCCAJFPAJJP != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JCCAJFPAJJP);
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
		if (CNIKGMAICAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CNIKGMAICAF);
		}
		if (JCCAJFPAJJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JCCAJFPAJJP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GPEJGPJNECF other)
	{
		if (other != null)
		{
			if (other.CNIKGMAICAF != 0)
			{
				CNIKGMAICAF = other.CNIKGMAICAF;
			}
			if (other.JCCAJFPAJJP != 0)
			{
				JCCAJFPAJJP = other.JCCAJFPAJJP;
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
				CNIKGMAICAF = input.ReadUInt32();
				break;
			case 40u:
				JCCAJFPAJJP = input.ReadUInt32();
				break;
			}
		}
	}
}
