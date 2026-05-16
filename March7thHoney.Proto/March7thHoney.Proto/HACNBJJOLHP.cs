using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HACNBJJOLHP : IMessage<HACNBJJOLHP>, IMessage, IEquatable<HACNBJJOLHP>, IDeepCloneable<HACNBJJOLHP>, IBufferMessage
{
	private static readonly MessageParser<HACNBJJOLHP> _parser = new MessageParser<HACNBJJOLHP>(() => new HACNBJJOLHP());

	private UnknownFieldSet _unknownFields;

	public const int BAPDMNKDLHGFieldNumber = 5;

	private uint bAPDMNKDLHG_;

	public const int IsNewFieldNumber = 9;

	private bool isNew_;

	public const int IdFieldNumber = 12;

	private uint id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HACNBJJOLHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HACNBJJOLHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BAPDMNKDLHG
	{
		get
		{
			return bAPDMNKDLHG_;
		}
		set
		{
			bAPDMNKDLHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsNew
	{
		get
		{
			return isNew_;
		}
		set
		{
			isNew_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HACNBJJOLHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HACNBJJOLHP(HACNBJJOLHP other)
		: this()
	{
		bAPDMNKDLHG_ = other.bAPDMNKDLHG_;
		isNew_ = other.isNew_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HACNBJJOLHP Clone()
	{
		return new HACNBJJOLHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HACNBJJOLHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HACNBJJOLHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BAPDMNKDLHG != other.BAPDMNKDLHG)
		{
			return false;
		}
		if (IsNew != other.IsNew)
		{
			return false;
		}
		if (Id != other.Id)
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
		if (BAPDMNKDLHG != 0)
		{
			num ^= BAPDMNKDLHG.GetHashCode();
		}
		if (IsNew)
		{
			num ^= IsNew.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (BAPDMNKDLHG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BAPDMNKDLHG);
		}
		if (IsNew)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsNew);
		}
		if (Id != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Id);
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
		if (BAPDMNKDLHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BAPDMNKDLHG);
		}
		if (IsNew)
		{
			num += 2;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HACNBJJOLHP other)
	{
		if (other != null)
		{
			if (other.BAPDMNKDLHG != 0)
			{
				BAPDMNKDLHG = other.BAPDMNKDLHG;
			}
			if (other.IsNew)
			{
				IsNew = other.IsNew;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 40u:
				BAPDMNKDLHG = input.ReadUInt32();
				break;
			case 72u:
				IsNew = input.ReadBool();
				break;
			case 96u:
				Id = input.ReadUInt32();
				break;
			}
		}
	}
}
