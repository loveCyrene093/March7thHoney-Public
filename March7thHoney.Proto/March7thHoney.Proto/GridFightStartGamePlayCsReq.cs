using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightStartGamePlayCsReq : IMessage<GridFightStartGamePlayCsReq>, IMessage, IEquatable<GridFightStartGamePlayCsReq>, IDeepCloneable<GridFightStartGamePlayCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightStartGamePlayCsReq> _parser = new MessageParser<GridFightStartGamePlayCsReq>(() => new GridFightStartGamePlayCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SeasonFieldNumber = 3;

	private uint season_;

	public const int IsOverlockFieldNumber = 13;

	private bool isOverlock_;

	public const int DivisionIdFieldNumber = 15;

	private uint divisionId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightStartGamePlayCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightStartGamePlayCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOverlock
	{
		get
		{
			return isOverlock_;
		}
		set
		{
			isOverlock_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DivisionId
	{
		get
		{
			return divisionId_;
		}
		set
		{
			divisionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightStartGamePlayCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightStartGamePlayCsReq(GridFightStartGamePlayCsReq other)
		: this()
	{
		season_ = other.season_;
		isOverlock_ = other.isOverlock_;
		divisionId_ = other.divisionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightStartGamePlayCsReq Clone()
	{
		return new GridFightStartGamePlayCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightStartGamePlayCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightStartGamePlayCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Season != other.Season)
		{
			return false;
		}
		if (IsOverlock != other.IsOverlock)
		{
			return false;
		}
		if (DivisionId != other.DivisionId)
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
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (IsOverlock)
		{
			num ^= IsOverlock.GetHashCode();
		}
		if (DivisionId != 0)
		{
			num ^= DivisionId.GetHashCode();
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
		if (Season != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Season);
		}
		if (IsOverlock)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsOverlock);
		}
		if (DivisionId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DivisionId);
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
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Season);
		}
		if (IsOverlock)
		{
			num += 2;
		}
		if (DivisionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DivisionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightStartGamePlayCsReq other)
	{
		if (other != null)
		{
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			if (other.IsOverlock)
			{
				IsOverlock = other.IsOverlock;
			}
			if (other.DivisionId != 0)
			{
				DivisionId = other.DivisionId;
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
			case 24u:
				Season = input.ReadUInt32();
				break;
			case 104u:
				IsOverlock = input.ReadBool();
				break;
			case 120u:
				DivisionId = input.ReadUInt32();
				break;
			}
		}
	}
}
