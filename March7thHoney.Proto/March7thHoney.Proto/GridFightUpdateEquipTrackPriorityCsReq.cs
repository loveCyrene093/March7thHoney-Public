using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightUpdateEquipTrackPriorityCsReq : IMessage<GridFightUpdateEquipTrackPriorityCsReq>, IMessage, IEquatable<GridFightUpdateEquipTrackPriorityCsReq>, IDeepCloneable<GridFightUpdateEquipTrackPriorityCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightUpdateEquipTrackPriorityCsReq> _parser = new MessageParser<GridFightUpdateEquipTrackPriorityCsReq>(() => new GridFightUpdateEquipTrackPriorityCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FHNOLJAHHNIFieldNumber = 10;

	private static readonly FieldCodec<CAOCJIENIEP> _repeated_fHNOLJAHHNI_codec = FieldCodec.ForMessage(82u, CAOCJIENIEP.Parser);

	private readonly RepeatedField<CAOCJIENIEP> fHNOLJAHHNI_ = new RepeatedField<CAOCJIENIEP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightUpdateEquipTrackPriorityCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightUpdateEquipTrackPriorityCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CAOCJIENIEP> FHNOLJAHHNI => fHNOLJAHHNI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateEquipTrackPriorityCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateEquipTrackPriorityCsReq(GridFightUpdateEquipTrackPriorityCsReq other)
		: this()
	{
		fHNOLJAHHNI_ = other.fHNOLJAHHNI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateEquipTrackPriorityCsReq Clone()
	{
		return new GridFightUpdateEquipTrackPriorityCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightUpdateEquipTrackPriorityCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightUpdateEquipTrackPriorityCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fHNOLJAHHNI_.Equals(other.fHNOLJAHHNI_))
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
		num ^= fHNOLJAHHNI_.GetHashCode();
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
		fHNOLJAHHNI_.WriteTo(ref output, _repeated_fHNOLJAHHNI_codec);
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
		num += fHNOLJAHHNI_.CalculateSize(_repeated_fHNOLJAHHNI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightUpdateEquipTrackPriorityCsReq other)
	{
		if (other != null)
		{
			fHNOLJAHHNI_.Add(other.fHNOLJAHHNI_);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fHNOLJAHHNI_.AddEntriesFrom(ref input, _repeated_fHNOLJAHHNI_codec);
			}
		}
	}
}
