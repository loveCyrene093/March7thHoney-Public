using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishAeonDialogueGroupCsReq : IMessage<FinishAeonDialogueGroupCsReq>, IMessage, IEquatable<FinishAeonDialogueGroupCsReq>, IDeepCloneable<FinishAeonDialogueGroupCsReq>, IBufferMessage
{
	private static readonly MessageParser<FinishAeonDialogueGroupCsReq> _parser = new MessageParser<FinishAeonDialogueGroupCsReq>(() => new FinishAeonDialogueGroupCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LGHOOKMNMCLFieldNumber = 1;

	private uint lGHOOKMNMCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishAeonDialogueGroupCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishAeonDialogueGroupCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGHOOKMNMCL
	{
		get
		{
			return lGHOOKMNMCL_;
		}
		set
		{
			lGHOOKMNMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishAeonDialogueGroupCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishAeonDialogueGroupCsReq(FinishAeonDialogueGroupCsReq other)
		: this()
	{
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishAeonDialogueGroupCsReq Clone()
	{
		return new FinishAeonDialogueGroupCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishAeonDialogueGroupCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishAeonDialogueGroupCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LGHOOKMNMCL != other.LGHOOKMNMCL)
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
		if (LGHOOKMNMCL != 0)
		{
			num ^= LGHOOKMNMCL.GetHashCode();
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
		if (LGHOOKMNMCL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LGHOOKMNMCL);
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
		if (LGHOOKMNMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGHOOKMNMCL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishAeonDialogueGroupCsReq other)
	{
		if (other != null)
		{
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				LGHOOKMNMCL = input.ReadUInt32();
			}
		}
	}
}
