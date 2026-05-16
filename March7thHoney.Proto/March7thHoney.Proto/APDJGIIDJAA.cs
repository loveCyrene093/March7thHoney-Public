using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APDJGIIDJAA : IMessage<APDJGIIDJAA>, IMessage, IEquatable<APDJGIIDJAA>, IDeepCloneable<APDJGIIDJAA>, IBufferMessage
{
	private static readonly MessageParser<APDJGIIDJAA> _parser = new MessageParser<APDJGIIDJAA>(() => new APDJGIIDJAA());

	private UnknownFieldSet _unknownFields;

	public const int AAAGBKEHKLCFieldNumber = 1;

	private uint aAAGBKEHKLC_;

	public const int KillMonsterListFieldNumber = 2;

	private static readonly FieldCodec<AFHIHMKCPNF> _repeated_killMonsterList_codec = FieldCodec.ForMessage(18u, AFHIHMKCPNF.Parser);

	private readonly RepeatedField<AFHIHMKCPNF> killMonsterList_ = new RepeatedField<AFHIHMKCPNF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APDJGIIDJAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APDJGIIDJAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAAGBKEHKLC
	{
		get
		{
			return aAAGBKEHKLC_;
		}
		set
		{
			aAAGBKEHKLC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AFHIHMKCPNF> KillMonsterList => killMonsterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APDJGIIDJAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APDJGIIDJAA(APDJGIIDJAA other)
		: this()
	{
		aAAGBKEHKLC_ = other.aAAGBKEHKLC_;
		killMonsterList_ = other.killMonsterList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APDJGIIDJAA Clone()
	{
		return new APDJGIIDJAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APDJGIIDJAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APDJGIIDJAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AAAGBKEHKLC != other.AAAGBKEHKLC)
		{
			return false;
		}
		if (!killMonsterList_.Equals(other.killMonsterList_))
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
		if (AAAGBKEHKLC != 0)
		{
			num ^= AAAGBKEHKLC.GetHashCode();
		}
		num ^= killMonsterList_.GetHashCode();
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
		if (AAAGBKEHKLC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AAAGBKEHKLC);
		}
		killMonsterList_.WriteTo(ref output, _repeated_killMonsterList_codec);
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
		if (AAAGBKEHKLC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAAGBKEHKLC);
		}
		num += killMonsterList_.CalculateSize(_repeated_killMonsterList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APDJGIIDJAA other)
	{
		if (other != null)
		{
			if (other.AAAGBKEHKLC != 0)
			{
				AAAGBKEHKLC = other.AAAGBKEHKLC;
			}
			killMonsterList_.Add(other.killMonsterList_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				AAAGBKEHKLC = input.ReadUInt32();
				break;
			case 18u:
				killMonsterList_.AddEntriesFrom(ref input, _repeated_killMonsterList_codec);
				break;
			}
		}
	}
}
