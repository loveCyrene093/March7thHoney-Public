using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncTurnFoodNotify : IMessage<SyncTurnFoodNotify>, IMessage, IEquatable<SyncTurnFoodNotify>, IDeepCloneable<SyncTurnFoodNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncTurnFoodNotify> _parser = new MessageParser<SyncTurnFoodNotify>(() => new SyncTurnFoodNotify());

	private UnknownFieldSet _unknownFields;

	public const int MAODNHNHLIJFieldNumber = 9;

	private static readonly FieldCodec<TurnFoodSwitch> _repeated_mAODNHNHLIJ_codec = FieldCodec.ForEnum(74u, (TurnFoodSwitch x) => (int)x, (int x) => (TurnFoodSwitch)x);

	private readonly RepeatedField<TurnFoodSwitch> mAODNHNHLIJ_ = new RepeatedField<TurnFoodSwitch>();

	public const int DBPDPHIMBDJFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_dBPDPHIMBDJ_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> dBPDPHIMBDJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncTurnFoodNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncTurnFoodNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TurnFoodSwitch> MAODNHNHLIJ => mAODNHNHLIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DBPDPHIMBDJ => dBPDPHIMBDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncTurnFoodNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncTurnFoodNotify(SyncTurnFoodNotify other)
		: this()
	{
		mAODNHNHLIJ_ = other.mAODNHNHLIJ_.Clone();
		dBPDPHIMBDJ_ = other.dBPDPHIMBDJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncTurnFoodNotify Clone()
	{
		return new SyncTurnFoodNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncTurnFoodNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncTurnFoodNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mAODNHNHLIJ_.Equals(other.mAODNHNHLIJ_))
		{
			return false;
		}
		if (!dBPDPHIMBDJ_.Equals(other.dBPDPHIMBDJ_))
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
		num ^= mAODNHNHLIJ_.GetHashCode();
		num ^= dBPDPHIMBDJ_.GetHashCode();
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
		mAODNHNHLIJ_.WriteTo(ref output, _repeated_mAODNHNHLIJ_codec);
		dBPDPHIMBDJ_.WriteTo(ref output, _repeated_dBPDPHIMBDJ_codec);
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
		num += mAODNHNHLIJ_.CalculateSize(_repeated_mAODNHNHLIJ_codec);
		num += dBPDPHIMBDJ_.CalculateSize(_repeated_dBPDPHIMBDJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncTurnFoodNotify other)
	{
		if (other != null)
		{
			mAODNHNHLIJ_.Add(other.mAODNHNHLIJ_);
			dBPDPHIMBDJ_.Add(other.dBPDPHIMBDJ_);
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
			case 74u:
				mAODNHNHLIJ_.AddEntriesFrom(ref input, _repeated_mAODNHNHLIJ_codec);
				break;
			case 120u:
			case 122u:
				dBPDPHIMBDJ_.AddEntriesFrom(ref input, _repeated_dBPDPHIMBDJ_codec);
				break;
			}
		}
	}
}
