using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CommonRogueVirtualItemInfoScNotify : IMessage<CommonRogueVirtualItemInfoScNotify>, IMessage, IEquatable<CommonRogueVirtualItemInfoScNotify>, IDeepCloneable<CommonRogueVirtualItemInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<CommonRogueVirtualItemInfoScNotify> _parser = new MessageParser<CommonRogueVirtualItemInfoScNotify>(() => new CommonRogueVirtualItemInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int DPEPAHNJCLOFieldNumber = 14;

	private static readonly FieldCodec<GMMAGELGJOL> _repeated_dPEPAHNJCLO_codec = FieldCodec.ForMessage(114u, GMMAGELGJOL.Parser);

	private readonly RepeatedField<GMMAGELGJOL> dPEPAHNJCLO_ = new RepeatedField<GMMAGELGJOL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CommonRogueVirtualItemInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CommonRogueVirtualItemInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GMMAGELGJOL> DPEPAHNJCLO => dPEPAHNJCLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueVirtualItemInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueVirtualItemInfoScNotify(CommonRogueVirtualItemInfoScNotify other)
		: this()
	{
		dPEPAHNJCLO_ = other.dPEPAHNJCLO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueVirtualItemInfoScNotify Clone()
	{
		return new CommonRogueVirtualItemInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CommonRogueVirtualItemInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CommonRogueVirtualItemInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dPEPAHNJCLO_.Equals(other.dPEPAHNJCLO_))
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
		num ^= dPEPAHNJCLO_.GetHashCode();
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
		dPEPAHNJCLO_.WriteTo(ref output, _repeated_dPEPAHNJCLO_codec);
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
		num += dPEPAHNJCLO_.CalculateSize(_repeated_dPEPAHNJCLO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CommonRogueVirtualItemInfoScNotify other)
	{
		if (other != null)
		{
			dPEPAHNJCLO_.Add(other.dPEPAHNJCLO_);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dPEPAHNJCLO_.AddEntriesFrom(ref input, _repeated_dPEPAHNJCLO_codec);
			}
		}
	}
}
