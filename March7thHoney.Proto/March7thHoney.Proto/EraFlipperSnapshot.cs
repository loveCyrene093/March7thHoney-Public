using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EraFlipperSnapshot : IMessage<EraFlipperSnapshot>, IMessage, IEquatable<EraFlipperSnapshot>, IDeepCloneable<EraFlipperSnapshot>, IBufferMessage
{
	private static readonly MessageParser<EraFlipperSnapshot> _parser = new MessageParser<EraFlipperSnapshot>(() => new EraFlipperSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int RegionDataListFieldNumber = 1;

	private static readonly FieldCodec<EraFlipperRegionDataSnapshot> _repeated_regionDataList_codec = FieldCodec.ForMessage(10u, EraFlipperRegionDataSnapshot.Parser);

	private readonly RepeatedField<EraFlipperRegionDataSnapshot> regionDataList_ = new RepeatedField<EraFlipperRegionDataSnapshot>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EraFlipperSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EraFlipperSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EraFlipperRegionDataSnapshot> RegionDataList => regionDataList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperSnapshot(EraFlipperSnapshot other)
		: this()
	{
		regionDataList_ = other.regionDataList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperSnapshot Clone()
	{
		return new EraFlipperSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EraFlipperSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EraFlipperSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!regionDataList_.Equals(other.regionDataList_))
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
		num ^= regionDataList_.GetHashCode();
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
		regionDataList_.WriteTo(ref output, _repeated_regionDataList_codec);
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
		num += regionDataList_.CalculateSize(_repeated_regionDataList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EraFlipperSnapshot other)
	{
		if (other != null)
		{
			regionDataList_.Add(other.regionDataList_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				regionDataList_.AddEntriesFrom(ref input, _repeated_regionDataList_codec);
			}
		}
	}
}
