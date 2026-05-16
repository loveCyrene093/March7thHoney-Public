using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightRouteInfo : IMessage<GridFightRouteInfo>, IMessage, IEquatable<GridFightRouteInfo>, IDeepCloneable<GridFightRouteInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightRouteInfo> _parser = new MessageParser<GridFightRouteInfo>(() => new GridFightRouteInfo());

	private UnknownFieldSet _unknownFields;

	public const int FightCampIdFieldNumber = 2;

	private uint fightCampId_;

	public const int EliteBranchIdFieldNumber = 7;

	private uint eliteBranchId_;

	public const int RouteEncounterListFieldNumber = 12;

	private static readonly FieldCodec<GridFightEncounterInfo> _repeated_routeEncounterList_codec = FieldCodec.ForMessage(98u, GridFightEncounterInfo.Parser);

	private readonly RepeatedField<GridFightEncounterInfo> routeEncounterList_ = new RepeatedField<GridFightEncounterInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightRouteInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightRouteInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FightCampId
	{
		get
		{
			return fightCampId_;
		}
		set
		{
			fightCampId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EliteBranchId
	{
		get
		{
			return eliteBranchId_;
		}
		set
		{
			eliteBranchId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightEncounterInfo> RouteEncounterList => routeEncounterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRouteInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRouteInfo(GridFightRouteInfo other)
		: this()
	{
		fightCampId_ = other.fightCampId_;
		eliteBranchId_ = other.eliteBranchId_;
		routeEncounterList_ = other.routeEncounterList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRouteInfo Clone()
	{
		return new GridFightRouteInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightRouteInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightRouteInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FightCampId != other.FightCampId)
		{
			return false;
		}
		if (EliteBranchId != other.EliteBranchId)
		{
			return false;
		}
		if (!routeEncounterList_.Equals(other.routeEncounterList_))
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
		if (FightCampId != 0)
		{
			num ^= FightCampId.GetHashCode();
		}
		if (EliteBranchId != 0)
		{
			num ^= EliteBranchId.GetHashCode();
		}
		num ^= routeEncounterList_.GetHashCode();
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
		if (FightCampId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FightCampId);
		}
		if (EliteBranchId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EliteBranchId);
		}
		routeEncounterList_.WriteTo(ref output, _repeated_routeEncounterList_codec);
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
		if (FightCampId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FightCampId);
		}
		if (EliteBranchId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EliteBranchId);
		}
		num += routeEncounterList_.CalculateSize(_repeated_routeEncounterList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightRouteInfo other)
	{
		if (other != null)
		{
			if (other.FightCampId != 0)
			{
				FightCampId = other.FightCampId;
			}
			if (other.EliteBranchId != 0)
			{
				EliteBranchId = other.EliteBranchId;
			}
			routeEncounterList_.Add(other.routeEncounterList_);
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
			case 16u:
				FightCampId = input.ReadUInt32();
				break;
			case 56u:
				EliteBranchId = input.ReadUInt32();
				break;
			case 98u:
				routeEncounterList_.AddEntriesFrom(ref input, _repeated_routeEncounterList_codec);
				break;
			}
		}
	}
}
