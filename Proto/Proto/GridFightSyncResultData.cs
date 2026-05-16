using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSyncResultData : IMessage<GridFightSyncResultData>, IMessage, IEquatable<GridFightSyncResultData>, IDeepCloneable<GridFightSyncResultData>, IBufferMessage
{
	private static readonly MessageParser<GridFightSyncResultData> _parser = new MessageParser<GridFightSyncResultData>(() => new GridFightSyncResultData());

	private UnknownFieldSet _unknownFields;

	public const int UpdateDynamicListFieldNumber = 4;

	private static readonly FieldCodec<GridFightSyncData> _repeated_updateDynamicList_codec = FieldCodec.ForMessage(34u, GridFightSyncData.Parser);

	private readonly RepeatedField<GridFightSyncData> updateDynamicList_ = new RepeatedField<GridFightSyncData>();

	public const int SyncEffectParamListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_syncEffectParamList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> syncEffectParamList_ = new RepeatedField<uint>();

	public const int GridUpdateSrcFieldNumber = 13;

	private GridFightUpdateSrcType gridUpdateSrc_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSyncResultData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSyncResultDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightSyncData> UpdateDynamicList => updateDynamicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SyncEffectParamList => syncEffectParamList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateSrcType GridUpdateSrc
	{
		get
		{
			return gridUpdateSrc_;
		}
		set
		{
			gridUpdateSrc_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncResultData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncResultData(GridFightSyncResultData other)
		: this()
	{
		updateDynamicList_ = other.updateDynamicList_.Clone();
		syncEffectParamList_ = other.syncEffectParamList_.Clone();
		gridUpdateSrc_ = other.gridUpdateSrc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncResultData Clone()
	{
		return new GridFightSyncResultData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSyncResultData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSyncResultData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!updateDynamicList_.Equals(other.updateDynamicList_))
		{
			return false;
		}
		if (!syncEffectParamList_.Equals(other.syncEffectParamList_))
		{
			return false;
		}
		if (GridUpdateSrc != other.GridUpdateSrc)
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
		num ^= updateDynamicList_.GetHashCode();
		num ^= syncEffectParamList_.GetHashCode();
		if (GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
		{
			num ^= GridUpdateSrc.GetHashCode();
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
		updateDynamicList_.WriteTo(ref output, _repeated_updateDynamicList_codec);
		syncEffectParamList_.WriteTo(ref output, _repeated_syncEffectParamList_codec);
		if (GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)GridUpdateSrc);
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
		num += updateDynamicList_.CalculateSize(_repeated_updateDynamicList_codec);
		num += syncEffectParamList_.CalculateSize(_repeated_syncEffectParamList_codec);
		if (GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GridUpdateSrc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSyncResultData other)
	{
		if (other != null)
		{
			updateDynamicList_.Add(other.updateDynamicList_);
			syncEffectParamList_.Add(other.syncEffectParamList_);
			if (other.GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
			{
				GridUpdateSrc = other.GridUpdateSrc;
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
			case 34u:
				updateDynamicList_.AddEntriesFrom(ref input, _repeated_updateDynamicList_codec);
				break;
			case 56u:
			case 58u:
				syncEffectParamList_.AddEntriesFrom(ref input, _repeated_syncEffectParamList_codec);
				break;
			case 104u:
				GridUpdateSrc = (GridFightUpdateSrcType)input.ReadEnum();
				break;
			}
		}
	}
}
