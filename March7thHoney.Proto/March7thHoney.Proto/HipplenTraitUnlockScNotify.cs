using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HipplenTraitUnlockScNotify : IMessage<HipplenTraitUnlockScNotify>, IMessage, IEquatable<HipplenTraitUnlockScNotify>, IDeepCloneable<HipplenTraitUnlockScNotify>, IBufferMessage
{
	private static readonly MessageParser<HipplenTraitUnlockScNotify> _parser = new MessageParser<HipplenTraitUnlockScNotify>(() => new HipplenTraitUnlockScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GridFightTraitInfoFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_gridFightTraitInfo_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> gridFightTraitInfo_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HipplenTraitUnlockScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HipplenTraitUnlockScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightTraitInfo => gridFightTraitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenTraitUnlockScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenTraitUnlockScNotify(HipplenTraitUnlockScNotify other)
		: this()
	{
		gridFightTraitInfo_ = other.gridFightTraitInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenTraitUnlockScNotify Clone()
	{
		return new HipplenTraitUnlockScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HipplenTraitUnlockScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HipplenTraitUnlockScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightTraitInfo_.Equals(other.gridFightTraitInfo_))
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
		num ^= gridFightTraitInfo_.GetHashCode();
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
		gridFightTraitInfo_.WriteTo(ref output, _repeated_gridFightTraitInfo_codec);
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
		num += gridFightTraitInfo_.CalculateSize(_repeated_gridFightTraitInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HipplenTraitUnlockScNotify other)
	{
		if (other != null)
		{
			gridFightTraitInfo_.Add(other.gridFightTraitInfo_);
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
			if (num != 104 && num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gridFightTraitInfo_.AddEntriesFrom(ref input, _repeated_gridFightTraitInfo_codec);
			}
		}
	}
}
