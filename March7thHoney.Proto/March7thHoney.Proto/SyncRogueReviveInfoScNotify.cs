using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueReviveInfoScNotify : IMessage<SyncRogueReviveInfoScNotify>, IMessage, IEquatable<SyncRogueReviveInfoScNotify>, IDeepCloneable<SyncRogueReviveInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueReviveInfoScNotify> _parser = new MessageParser<SyncRogueReviveInfoScNotify>(() => new SyncRogueReviveInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int PAMGHMDJAJAFieldNumber = 13;

	private DCOKKBHKEGL pAMGHMDJAJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueReviveInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueReviveInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCOKKBHKEGL PAMGHMDJAJA
	{
		get
		{
			return pAMGHMDJAJA_;
		}
		set
		{
			pAMGHMDJAJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueReviveInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueReviveInfoScNotify(SyncRogueReviveInfoScNotify other)
		: this()
	{
		pAMGHMDJAJA_ = ((other.pAMGHMDJAJA_ != null) ? other.pAMGHMDJAJA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueReviveInfoScNotify Clone()
	{
		return new SyncRogueReviveInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueReviveInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueReviveInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PAMGHMDJAJA, other.PAMGHMDJAJA))
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
		if (pAMGHMDJAJA_ != null)
		{
			num ^= PAMGHMDJAJA.GetHashCode();
		}
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
		if (pAMGHMDJAJA_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(PAMGHMDJAJA);
		}
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
		if (pAMGHMDJAJA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PAMGHMDJAJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueReviveInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pAMGHMDJAJA_ != null)
		{
			if (pAMGHMDJAJA_ == null)
			{
				PAMGHMDJAJA = new DCOKKBHKEGL();
			}
			PAMGHMDJAJA.MergeFrom(other.PAMGHMDJAJA);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pAMGHMDJAJA_ == null)
			{
				PAMGHMDJAJA = new DCOKKBHKEGL();
			}
			input.ReadMessage(PAMGHMDJAJA);
		}
	}
}
