using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionGroupWarnScNotify : IMessage<MissionGroupWarnScNotify>, IMessage, IEquatable<MissionGroupWarnScNotify>, IDeepCloneable<MissionGroupWarnScNotify>, IBufferMessage
{
	private static readonly MessageParser<MissionGroupWarnScNotify> _parser = new MessageParser<MissionGroupWarnScNotify>(() => new MissionGroupWarnScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LGEEPLGBAOMFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_lGEEPLGBAOM_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> lGEEPLGBAOM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionGroupWarnScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionGroupWarnScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LGEEPLGBAOM => lGEEPLGBAOM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionGroupWarnScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionGroupWarnScNotify(MissionGroupWarnScNotify other)
		: this()
	{
		lGEEPLGBAOM_ = other.lGEEPLGBAOM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionGroupWarnScNotify Clone()
	{
		return new MissionGroupWarnScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionGroupWarnScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionGroupWarnScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lGEEPLGBAOM_.Equals(other.lGEEPLGBAOM_))
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
		num ^= lGEEPLGBAOM_.GetHashCode();
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
		lGEEPLGBAOM_.WriteTo(ref output, _repeated_lGEEPLGBAOM_codec);
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
		num += lGEEPLGBAOM_.CalculateSize(_repeated_lGEEPLGBAOM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionGroupWarnScNotify other)
	{
		if (other != null)
		{
			lGEEPLGBAOM_.Add(other.lGEEPLGBAOM_);
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
			if (num != 120 && num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lGEEPLGBAOM_.AddEntriesFrom(ref input, _repeated_lGEEPLGBAOM_codec);
			}
		}
	}
}
