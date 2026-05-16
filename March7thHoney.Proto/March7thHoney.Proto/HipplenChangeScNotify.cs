using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HipplenChangeScNotify : IMessage<HipplenChangeScNotify>, IMessage, IEquatable<HipplenChangeScNotify>, IDeepCloneable<HipplenChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<HipplenChangeScNotify> _parser = new MessageParser<HipplenChangeScNotify>(() => new HipplenChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CJFBLHNPHAKFieldNumber = 11;

	private static readonly FieldCodec<KPHIHKGCHGO> _repeated_cJFBLHNPHAK_codec = FieldCodec.ForMessage(90u, KPHIHKGCHGO.Parser);

	private readonly RepeatedField<KPHIHKGCHGO> cJFBLHNPHAK_ = new RepeatedField<KPHIHKGCHGO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HipplenChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HipplenChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KPHIHKGCHGO> CJFBLHNPHAK => cJFBLHNPHAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenChangeScNotify(HipplenChangeScNotify other)
		: this()
	{
		cJFBLHNPHAK_ = other.cJFBLHNPHAK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenChangeScNotify Clone()
	{
		return new HipplenChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HipplenChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HipplenChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cJFBLHNPHAK_.Equals(other.cJFBLHNPHAK_))
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
		num ^= cJFBLHNPHAK_.GetHashCode();
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
		cJFBLHNPHAK_.WriteTo(ref output, _repeated_cJFBLHNPHAK_codec);
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
		num += cJFBLHNPHAK_.CalculateSize(_repeated_cJFBLHNPHAK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HipplenChangeScNotify other)
	{
		if (other != null)
		{
			cJFBLHNPHAK_.Add(other.cJFBLHNPHAK_);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cJFBLHNPHAK_.AddEntriesFrom(ref input, _repeated_cJFBLHNPHAK_codec);
			}
		}
	}
}
