using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NMHKDLJPGIL : IMessage<NMHKDLJPGIL>, IMessage, IEquatable<NMHKDLJPGIL>, IDeepCloneable<NMHKDLJPGIL>, IBufferMessage
{
	private static readonly MessageParser<NMHKDLJPGIL> _parser = new MessageParser<NMHKDLJPGIL>(() => new NMHKDLJPGIL());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 9;

	private uint groupId_;

	public const int PBOLMBLKDNDFieldNumber = 10;

	private uint pBOLMBLKDND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NMHKDLJPGIL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NMHKDLJPGILReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBOLMBLKDND
	{
		get
		{
			return pBOLMBLKDND_;
		}
		set
		{
			pBOLMBLKDND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMHKDLJPGIL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMHKDLJPGIL(NMHKDLJPGIL other)
		: this()
	{
		groupId_ = other.groupId_;
		pBOLMBLKDND_ = other.pBOLMBLKDND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMHKDLJPGIL Clone()
	{
		return new NMHKDLJPGIL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NMHKDLJPGIL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NMHKDLJPGIL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (PBOLMBLKDND != other.PBOLMBLKDND)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (PBOLMBLKDND != 0)
		{
			num ^= PBOLMBLKDND.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GroupId);
		}
		if (PBOLMBLKDND != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PBOLMBLKDND);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (PBOLMBLKDND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBOLMBLKDND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NMHKDLJPGIL other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.PBOLMBLKDND != 0)
			{
				PBOLMBLKDND = other.PBOLMBLKDND;
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
			case 72u:
				GroupId = input.ReadUInt32();
				break;
			case 80u:
				PBOLMBLKDND = input.ReadUInt32();
				break;
			}
		}
	}
}
