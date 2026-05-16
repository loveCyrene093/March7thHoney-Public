using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueNpcDisappearCsReq : IMessage<RogueNpcDisappearCsReq>, IMessage, IEquatable<RogueNpcDisappearCsReq>, IDeepCloneable<RogueNpcDisappearCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueNpcDisappearCsReq> _parser = new MessageParser<RogueNpcDisappearCsReq>(() => new RogueNpcDisappearCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CCLNDIJNJDPFieldNumber = 14;

	private uint cCLNDIJNJDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueNpcDisappearCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueNpcDisappearCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CCLNDIJNJDP
	{
		get
		{
			return cCLNDIJNJDP_;
		}
		set
		{
			cCLNDIJNJDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueNpcDisappearCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueNpcDisappearCsReq(RogueNpcDisappearCsReq other)
		: this()
	{
		cCLNDIJNJDP_ = other.cCLNDIJNJDP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueNpcDisappearCsReq Clone()
	{
		return new RogueNpcDisappearCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueNpcDisappearCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueNpcDisappearCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CCLNDIJNJDP != other.CCLNDIJNJDP)
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
		if (CCLNDIJNJDP != 0)
		{
			num ^= CCLNDIJNJDP.GetHashCode();
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
		if (CCLNDIJNJDP != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CCLNDIJNJDP);
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
		if (CCLNDIJNJDP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CCLNDIJNJDP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueNpcDisappearCsReq other)
	{
		if (other != null)
		{
			if (other.CCLNDIJNJDP != 0)
			{
				CCLNDIJNJDP = other.CCLNDIJNJDP;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CCLNDIJNJDP = input.ReadUInt32();
			}
		}
	}
}
