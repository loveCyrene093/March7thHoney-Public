using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMCEJJJOCAP : IMessage<DMCEJJJOCAP>, IMessage, IEquatable<DMCEJJJOCAP>, IDeepCloneable<DMCEJJJOCAP>, IBufferMessage
{
	private static readonly MessageParser<DMCEJJJOCAP> _parser = new MessageParser<DMCEJJJOCAP>(() => new DMCEJJJOCAP());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 7;

	private OBCFJPGNALP reason_;

	public const int JLEILOGLJNJFieldNumber = 14;

	private ulong jLEILOGLJNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMCEJJJOCAP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMCEJJJOCAPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBCFJPGNALP Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong JLEILOGLJNJ
	{
		get
		{
			return jLEILOGLJNJ_;
		}
		set
		{
			jLEILOGLJNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMCEJJJOCAP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMCEJJJOCAP(DMCEJJJOCAP other)
		: this()
	{
		reason_ = other.reason_;
		jLEILOGLJNJ_ = other.jLEILOGLJNJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMCEJJJOCAP Clone()
	{
		return new DMCEJJJOCAP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMCEJJJOCAP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMCEJJJOCAP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (JLEILOGLJNJ != other.JLEILOGLJNJ)
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
		if (Reason != OBCFJPGNALP.Pcpdhelpkem)
		{
			num ^= Reason.GetHashCode();
		}
		if (JLEILOGLJNJ != 0L)
		{
			num ^= JLEILOGLJNJ.GetHashCode();
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
		if (Reason != OBCFJPGNALP.Pcpdhelpkem)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Reason);
		}
		if (JLEILOGLJNJ != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(JLEILOGLJNJ);
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
		if (Reason != OBCFJPGNALP.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (JLEILOGLJNJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(JLEILOGLJNJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMCEJJJOCAP other)
	{
		if (other != null)
		{
			if (other.Reason != OBCFJPGNALP.Pcpdhelpkem)
			{
				Reason = other.Reason;
			}
			if (other.JLEILOGLJNJ != 0L)
			{
				JLEILOGLJNJ = other.JLEILOGLJNJ;
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
			case 56u:
				Reason = (OBCFJPGNALP)input.ReadEnum();
				break;
			case 112u:
				JLEILOGLJNJ = input.ReadUInt64();
				break;
			}
		}
	}
}
