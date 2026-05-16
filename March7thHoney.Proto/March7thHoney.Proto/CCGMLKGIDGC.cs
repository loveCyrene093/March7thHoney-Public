using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCGMLKGIDGC : IMessage<CCGMLKGIDGC>, IMessage, IEquatable<CCGMLKGIDGC>, IDeepCloneable<CCGMLKGIDGC>, IBufferMessage
{
	private static readonly MessageParser<CCGMLKGIDGC> _parser = new MessageParser<CCGMLKGIDGC>(() => new CCGMLKGIDGC());

	private UnknownFieldSet _unknownFields;

	public const int GKOLNNKHNGPFieldNumber = 1;

	private uint gKOLNNKHNGP_;

	public const int GKJACLFBJKDFieldNumber = 2;

	private uint gKJACLFBJKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCGMLKGIDGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCGMLKGIDGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKOLNNKHNGP
	{
		get
		{
			return gKOLNNKHNGP_;
		}
		set
		{
			gKOLNNKHNGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKJACLFBJKD
	{
		get
		{
			return gKJACLFBJKD_;
		}
		set
		{
			gKJACLFBJKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCGMLKGIDGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCGMLKGIDGC(CCGMLKGIDGC other)
		: this()
	{
		gKOLNNKHNGP_ = other.gKOLNNKHNGP_;
		gKJACLFBJKD_ = other.gKJACLFBJKD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCGMLKGIDGC Clone()
	{
		return new CCGMLKGIDGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCGMLKGIDGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCGMLKGIDGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GKOLNNKHNGP != other.GKOLNNKHNGP)
		{
			return false;
		}
		if (GKJACLFBJKD != other.GKJACLFBJKD)
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
		if (GKOLNNKHNGP != 0)
		{
			num ^= GKOLNNKHNGP.GetHashCode();
		}
		if (GKJACLFBJKD != 0)
		{
			num ^= GKJACLFBJKD.GetHashCode();
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
		if (GKOLNNKHNGP != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GKOLNNKHNGP);
		}
		if (GKJACLFBJKD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GKJACLFBJKD);
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
		if (GKOLNNKHNGP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKOLNNKHNGP);
		}
		if (GKJACLFBJKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKJACLFBJKD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCGMLKGIDGC other)
	{
		if (other != null)
		{
			if (other.GKOLNNKHNGP != 0)
			{
				GKOLNNKHNGP = other.GKOLNNKHNGP;
			}
			if (other.GKJACLFBJKD != 0)
			{
				GKJACLFBJKD = other.GKJACLFBJKD;
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
			case 8u:
				GKOLNNKHNGP = input.ReadUInt32();
				break;
			case 16u:
				GKJACLFBJKD = input.ReadUInt32();
				break;
			}
		}
	}
}
