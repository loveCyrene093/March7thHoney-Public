using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CEIIEHNDPAJ : IMessage<CEIIEHNDPAJ>, IMessage, IEquatable<CEIIEHNDPAJ>, IDeepCloneable<CEIIEHNDPAJ>, IBufferMessage
{
	private static readonly MessageParser<CEIIEHNDPAJ> _parser = new MessageParser<CEIIEHNDPAJ>(() => new CEIIEHNDPAJ());

	private UnknownFieldSet _unknownFields;

	public const int GridUpdateSrcFieldNumber = 3;

	private GridFightUpdateSrcType gridUpdateSrc_;

	public const int UpdateDynamicListFieldNumber = 7;

	private static readonly FieldCodec<GridFightSyncData> _repeated_updateDynamicList_codec = FieldCodec.ForMessage(58u, GridFightSyncData.Parser);

	private readonly RepeatedField<GridFightSyncData> updateDynamicList_ = new RepeatedField<GridFightSyncData>();

	public const int SyncEffectParamListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_syncEffectParamList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> syncEffectParamList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CEIIEHNDPAJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CEIIEHNDPAJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<GridFightSyncData> UpdateDynamicList => updateDynamicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SyncEffectParamList => syncEffectParamList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEIIEHNDPAJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEIIEHNDPAJ(CEIIEHNDPAJ other)
		: this()
	{
		gridUpdateSrc_ = other.gridUpdateSrc_;
		updateDynamicList_ = other.updateDynamicList_.Clone();
		syncEffectParamList_ = other.syncEffectParamList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEIIEHNDPAJ Clone()
	{
		return new CEIIEHNDPAJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CEIIEHNDPAJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CEIIEHNDPAJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GridUpdateSrc != other.GridUpdateSrc)
		{
			return false;
		}
		if (!updateDynamicList_.Equals(other.updateDynamicList_))
		{
			return false;
		}
		if (!syncEffectParamList_.Equals(other.syncEffectParamList_))
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
		if (GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
		{
			num ^= GridUpdateSrc.GetHashCode();
		}
		num ^= updateDynamicList_.GetHashCode();
		num ^= syncEffectParamList_.GetHashCode();
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
		if (GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)GridUpdateSrc);
		}
		updateDynamicList_.WriteTo(ref output, _repeated_updateDynamicList_codec);
		syncEffectParamList_.WriteTo(ref output, _repeated_syncEffectParamList_codec);
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
		if (GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GridUpdateSrc);
		}
		num += updateDynamicList_.CalculateSize(_repeated_updateDynamicList_codec);
		num += syncEffectParamList_.CalculateSize(_repeated_syncEffectParamList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CEIIEHNDPAJ other)
	{
		if (other != null)
		{
			if (other.GridUpdateSrc != GridFightUpdateSrcType.LnpfefkjdhpHefepinlbdp)
			{
				GridUpdateSrc = other.GridUpdateSrc;
			}
			updateDynamicList_.Add(other.updateDynamicList_);
			syncEffectParamList_.Add(other.syncEffectParamList_);
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
				GridUpdateSrc = (GridFightUpdateSrcType)input.ReadEnum();
				break;
			case 58u:
				updateDynamicList_.AddEntriesFrom(ref input, _repeated_updateDynamicList_codec);
				break;
			case 88u:
			case 90u:
				syncEffectParamList_.AddEntriesFrom(ref input, _repeated_syncEffectParamList_codec);
				break;
			}
		}
	}
}
