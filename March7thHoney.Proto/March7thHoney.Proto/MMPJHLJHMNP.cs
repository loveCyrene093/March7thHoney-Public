using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MMPJHLJHMNP : IMessage<MMPJHLJHMNP>, IMessage, IEquatable<MMPJHLJHMNP>, IDeepCloneable<MMPJHLJHMNP>, IBufferMessage
{
	private static readonly MessageParser<MMPJHLJHMNP> _parser = new MessageParser<MMPJHLJHMNP>(() => new MMPJHLJHMNP());

	private UnknownFieldSet _unknownFields;

	public const int DHPHLCHPKFLFieldNumber = 4;

	private uint dHPHLCHPKFL_;

	public const int INOMFFAIEOAFieldNumber = 7;

	private uint iNOMFFAIEOA_;

	public const int GroupIdFieldNumber = 10;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MMPJHLJHMNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MMPJHLJHMNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHPHLCHPKFL
	{
		get
		{
			return dHPHLCHPKFL_;
		}
		set
		{
			dHPHLCHPKFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INOMFFAIEOA
	{
		get
		{
			return iNOMFFAIEOA_;
		}
		set
		{
			iNOMFFAIEOA_ = value;
		}
	}

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
	public MMPJHLJHMNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMPJHLJHMNP(MMPJHLJHMNP other)
		: this()
	{
		dHPHLCHPKFL_ = other.dHPHLCHPKFL_;
		iNOMFFAIEOA_ = other.iNOMFFAIEOA_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMPJHLJHMNP Clone()
	{
		return new MMPJHLJHMNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MMPJHLJHMNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MMPJHLJHMNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DHPHLCHPKFL != other.DHPHLCHPKFL)
		{
			return false;
		}
		if (INOMFFAIEOA != other.INOMFFAIEOA)
		{
			return false;
		}
		if (GroupId != other.GroupId)
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
		if (DHPHLCHPKFL != 0)
		{
			num ^= DHPHLCHPKFL.GetHashCode();
		}
		if (INOMFFAIEOA != 0)
		{
			num ^= INOMFFAIEOA.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
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
		if (DHPHLCHPKFL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DHPHLCHPKFL);
		}
		if (INOMFFAIEOA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(INOMFFAIEOA);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GroupId);
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
		if (DHPHLCHPKFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHPHLCHPKFL);
		}
		if (INOMFFAIEOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INOMFFAIEOA);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MMPJHLJHMNP other)
	{
		if (other != null)
		{
			if (other.DHPHLCHPKFL != 0)
			{
				DHPHLCHPKFL = other.DHPHLCHPKFL;
			}
			if (other.INOMFFAIEOA != 0)
			{
				INOMFFAIEOA = other.INOMFFAIEOA;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
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
				DHPHLCHPKFL = input.ReadUInt32();
				break;
			case 56u:
				INOMFFAIEOA = input.ReadUInt32();
				break;
			case 80u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
