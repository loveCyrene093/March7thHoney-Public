using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueStatusScNotify : IMessage<SyncRogueStatusScNotify>, IMessage, IEquatable<SyncRogueStatusScNotify>, IDeepCloneable<SyncRogueStatusScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueStatusScNotify> _parser = new MessageParser<SyncRogueStatusScNotify>(() => new SyncRogueStatusScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CGNNKGAAHIOFieldNumber = 11;

	private bool cGNNKGAAHIO_;

	public const int StatusFieldNumber = 14;

	private RogueStatus status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueStatusScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueStatusScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CGNNKGAAHIO
	{
		get
		{
			return cGNNKGAAHIO_;
		}
		set
		{
			cGNNKGAAHIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueStatusScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueStatusScNotify(SyncRogueStatusScNotify other)
		: this()
	{
		cGNNKGAAHIO_ = other.cGNNKGAAHIO_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueStatusScNotify Clone()
	{
		return new SyncRogueStatusScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueStatusScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueStatusScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CGNNKGAAHIO != other.CGNNKGAAHIO)
		{
			return false;
		}
		if (Status != other.Status)
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
		if (CGNNKGAAHIO)
		{
			num ^= CGNNKGAAHIO.GetHashCode();
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
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
		if (CGNNKGAAHIO)
		{
			output.WriteRawTag(88);
			output.WriteBool(CGNNKGAAHIO);
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)Status);
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
		if (CGNNKGAAHIO)
		{
			num += 2;
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueStatusScNotify other)
	{
		if (other != null)
		{
			if (other.CGNNKGAAHIO)
			{
				CGNNKGAAHIO = other.CGNNKGAAHIO;
			}
			if (other.Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
			{
				Status = other.Status;
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
			case 88u:
				CGNNKGAAHIO = input.ReadBool();
				break;
			case 112u:
				Status = (RogueStatus)input.ReadEnum();
				break;
			}
		}
	}
}
