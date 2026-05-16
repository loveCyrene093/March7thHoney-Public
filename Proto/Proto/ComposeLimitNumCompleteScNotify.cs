using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ComposeLimitNumCompleteScNotify : IMessage<ComposeLimitNumCompleteScNotify>, IMessage, IEquatable<ComposeLimitNumCompleteScNotify>, IDeepCloneable<ComposeLimitNumCompleteScNotify>, IBufferMessage
{
	private static readonly MessageParser<ComposeLimitNumCompleteScNotify> _parser = new MessageParser<ComposeLimitNumCompleteScNotify>(() => new ComposeLimitNumCompleteScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BPCEJLENHIJFieldNumber = 2;

	private static readonly FieldCodec<GHFBGBPMPFL> _repeated_bPCEJLENHIJ_codec = FieldCodec.ForMessage(18u, GHFBGBPMPFL.Parser);

	private readonly RepeatedField<GHFBGBPMPFL> bPCEJLENHIJ_ = new RepeatedField<GHFBGBPMPFL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ComposeLimitNumCompleteScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ComposeLimitNumCompleteScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GHFBGBPMPFL> BPCEJLENHIJ => bPCEJLENHIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeLimitNumCompleteScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeLimitNumCompleteScNotify(ComposeLimitNumCompleteScNotify other)
		: this()
	{
		bPCEJLENHIJ_ = other.bPCEJLENHIJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeLimitNumCompleteScNotify Clone()
	{
		return new ComposeLimitNumCompleteScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ComposeLimitNumCompleteScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ComposeLimitNumCompleteScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bPCEJLENHIJ_.Equals(other.bPCEJLENHIJ_))
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
		num ^= bPCEJLENHIJ_.GetHashCode();
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
		bPCEJLENHIJ_.WriteTo(ref output, _repeated_bPCEJLENHIJ_codec);
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
		num += bPCEJLENHIJ_.CalculateSize(_repeated_bPCEJLENHIJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ComposeLimitNumCompleteScNotify other)
	{
		if (other != null)
		{
			bPCEJLENHIJ_.Add(other.bPCEJLENHIJ_);
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
				bPCEJLENHIJ_.AddEntriesFrom(ref input, _repeated_bPCEJLENHIJ_codec);
			}
		}
	}
}
