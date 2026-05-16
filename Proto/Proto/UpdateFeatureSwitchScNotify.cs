using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateFeatureSwitchScNotify : IMessage<UpdateFeatureSwitchScNotify>, IMessage, IEquatable<UpdateFeatureSwitchScNotify>, IDeepCloneable<UpdateFeatureSwitchScNotify>, IBufferMessage
{
	private static readonly MessageParser<UpdateFeatureSwitchScNotify> _parser = new MessageParser<UpdateFeatureSwitchScNotify>(() => new UpdateFeatureSwitchScNotify());

	private UnknownFieldSet _unknownFields;

	public const int SwitchInfoListFieldNumber = 6;

	private static readonly FieldCodec<CENOIEMJPKK> _repeated_switchInfoList_codec = FieldCodec.ForMessage(50u, CENOIEMJPKK.Parser);

	private readonly RepeatedField<CENOIEMJPKK> switchInfoList_ = new RepeatedField<CENOIEMJPKK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateFeatureSwitchScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateFeatureSwitchScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CENOIEMJPKK> SwitchInfoList => switchInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateFeatureSwitchScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateFeatureSwitchScNotify(UpdateFeatureSwitchScNotify other)
		: this()
	{
		switchInfoList_ = other.switchInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateFeatureSwitchScNotify Clone()
	{
		return new UpdateFeatureSwitchScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateFeatureSwitchScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateFeatureSwitchScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!switchInfoList_.Equals(other.switchInfoList_))
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
		num ^= switchInfoList_.GetHashCode();
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
		switchInfoList_.WriteTo(ref output, _repeated_switchInfoList_codec);
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
		num += switchInfoList_.CalculateSize(_repeated_switchInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateFeatureSwitchScNotify other)
	{
		if (other != null)
		{
			switchInfoList_.Add(other.switchInfoList_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				switchInfoList_.AddEntriesFrom(ref input, _repeated_switchInfoList_codec);
			}
		}
	}
}
