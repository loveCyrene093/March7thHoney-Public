using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncChangeNtf : IMessage<SyncChangeNtf>, IMessage, IEquatable<SyncChangeNtf>, IDeepCloneable<SyncChangeNtf>, IBufferMessage
{
	private static readonly MessageParser<SyncChangeNtf> _parser = new MessageParser<SyncChangeNtf>(() => new SyncChangeNtf());

	private UnknownFieldSet _unknownFields;

	public const int CJFBLHNPHAKFieldNumber = 9;

	private static readonly FieldCodec<FAIGHIPDKIG> _repeated_cJFBLHNPHAK_codec = FieldCodec.ForMessage(74u, FAIGHIPDKIG.Parser);

	private readonly RepeatedField<FAIGHIPDKIG> cJFBLHNPHAK_ = new RepeatedField<FAIGHIPDKIG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncChangeNtf> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncChangeNtfReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FAIGHIPDKIG> CJFBLHNPHAK => cJFBLHNPHAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChangeNtf()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChangeNtf(SyncChangeNtf other)
		: this()
	{
		cJFBLHNPHAK_ = other.cJFBLHNPHAK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChangeNtf Clone()
	{
		return new SyncChangeNtf(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncChangeNtf);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncChangeNtf other)
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
	public void MergeFrom(SyncChangeNtf other)
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
			if (num != 74)
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
