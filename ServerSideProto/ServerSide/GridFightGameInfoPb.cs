using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameInfoPb : IMessage<GridFightGameInfoPb>, IMessage, IEquatable<GridFightGameInfoPb>, IDeepCloneable<GridFightGameInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameInfoPb> _parser = new MessageParser<GridFightGameInfoPb>(() => new GridFightGameInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 1;

	private uint uniqueId_;

	public const int DivisionIdFieldNumber = 2;

	private uint divisionId_;

	public const int IsOverLockFieldNumber = 3;

	private bool isOverLock_;

	public const int SeasonFieldNumber = 4;

	private uint season_;

	public const int ComponentsFieldNumber = 5;

	private static readonly FieldCodec<GridFightComponentPb> _repeated_components_codec = FieldCodec.ForMessage(42u, GridFightComponentPb.Parser);

	private readonly RepeatedField<GridFightComponentPb> components_ = new RepeatedField<GridFightComponentPb>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
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
	public bool IsOverLock
	{
		get
		{
			return isOverLock_;
		}
		set
		{
			isOverLock_ = value;
		}
	}

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
	public RepeatedField<GridFightComponentPb> Components => components_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameInfoPb(GridFightGameInfoPb other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		divisionId_ = other.divisionId_;
		isOverLock_ = other.isOverLock_;
		season_ = other.season_;
		components_ = other.components_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameInfoPb Clone()
	{
		return new GridFightGameInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (DivisionId != other.DivisionId)
		{
			return false;
		}
		if (IsOverLock != other.IsOverLock)
		{
			return false;
		}
		if (Season != other.Season)
		{
			return false;
		}
		if (!components_.Equals(other.components_))
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (DivisionId != 0)
		{
			num ^= DivisionId.GetHashCode();
		}
		if (IsOverLock)
		{
			num ^= IsOverLock.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		num ^= components_.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(UniqueId);
		}
		if (DivisionId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DivisionId);
		}
		if (IsOverLock)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsOverLock);
		}
		if (Season != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Season);
		}
		components_.WriteTo(ref output, _repeated_components_codec);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (DivisionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DivisionId);
		}
		if (IsOverLock)
		{
			num += 2;
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Season);
		}
		num += components_.CalculateSize(_repeated_components_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameInfoPb other)
	{
		if (other != null)
		{
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.DivisionId != 0)
			{
				DivisionId = other.DivisionId;
			}
			if (other.IsOverLock)
			{
				IsOverLock = other.IsOverLock;
			}
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			components_.Add(other.components_);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				UniqueId = input.ReadUInt32();
				break;
			case 16u:
				DivisionId = input.ReadUInt32();
				break;
			case 24u:
				IsOverLock = input.ReadBool();
				break;
			case 32u:
				Season = input.ReadUInt32();
				break;
			case 42u:
				components_.AddEntriesFrom(ref input, _repeated_components_codec);
				break;
			}
		}
	}
}
