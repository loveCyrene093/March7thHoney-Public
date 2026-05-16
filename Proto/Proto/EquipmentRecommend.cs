using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EquipmentRecommend : IMessage<EquipmentRecommend>, IMessage, IEquatable<EquipmentRecommend>, IDeepCloneable<EquipmentRecommend>, IBufferMessage
{
	private static readonly MessageParser<EquipmentRecommend> _parser = new MessageParser<EquipmentRecommend>(() => new EquipmentRecommend());

	private UnknownFieldSet _unknownFields;

	public const int EquipmentListFieldNumber = 2;

	private static readonly FieldCodec<JEFIKHKJFCM> _repeated_equipmentList_codec = FieldCodec.ForMessage(18u, JEFIKHKJFCM.Parser);

	private readonly RepeatedField<JEFIKHKJFCM> equipmentList_ = new RepeatedField<JEFIKHKJFCM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipmentRecommend> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipmentRecommendReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JEFIKHKJFCM> EquipmentList => equipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentRecommend()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentRecommend(EquipmentRecommend other)
		: this()
	{
		equipmentList_ = other.equipmentList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentRecommend Clone()
	{
		return new EquipmentRecommend(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentRecommend);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipmentRecommend other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!equipmentList_.Equals(other.equipmentList_))
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
		num ^= equipmentList_.GetHashCode();
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
		equipmentList_.WriteTo(ref output, _repeated_equipmentList_codec);
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
		num += equipmentList_.CalculateSize(_repeated_equipmentList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipmentRecommend other)
	{
		if (other != null)
		{
			equipmentList_.Add(other.equipmentList_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				equipmentList_.AddEntriesFrom(ref input, _repeated_equipmentList_codec);
			}
		}
	}
}
