using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyDailySettleScNotify : IMessage<MonopolyDailySettleScNotify>, IMessage, IEquatable<MonopolyDailySettleScNotify>, IDeepCloneable<MonopolyDailySettleScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyDailySettleScNotify> _parser = new MessageParser<MonopolyDailySettleScNotify>(() => new MonopolyDailySettleScNotify());

	private UnknownFieldSet _unknownFields;

	public const int EOBENDPKFBOFieldNumber = 3;

	private ODONLHDAPKB eOBENDPKFBO_;

	public const int LFGMMAPKDICFieldNumber = 15;

	private uint lFGMMAPKDIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyDailySettleScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyDailySettleScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODONLHDAPKB EOBENDPKFBO
	{
		get
		{
			return eOBENDPKFBO_;
		}
		set
		{
			eOBENDPKFBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFGMMAPKDIC
	{
		get
		{
			return lFGMMAPKDIC_;
		}
		set
		{
			lFGMMAPKDIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyDailySettleScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyDailySettleScNotify(MonopolyDailySettleScNotify other)
		: this()
	{
		eOBENDPKFBO_ = ((other.eOBENDPKFBO_ != null) ? other.eOBENDPKFBO_.Clone() : null);
		lFGMMAPKDIC_ = other.lFGMMAPKDIC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyDailySettleScNotify Clone()
	{
		return new MonopolyDailySettleScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyDailySettleScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyDailySettleScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EOBENDPKFBO, other.EOBENDPKFBO))
		{
			return false;
		}
		if (LFGMMAPKDIC != other.LFGMMAPKDIC)
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
		if (eOBENDPKFBO_ != null)
		{
			num ^= EOBENDPKFBO.GetHashCode();
		}
		if (LFGMMAPKDIC != 0)
		{
			num ^= LFGMMAPKDIC.GetHashCode();
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
		if (eOBENDPKFBO_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EOBENDPKFBO);
		}
		if (LFGMMAPKDIC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LFGMMAPKDIC);
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
		if (eOBENDPKFBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOBENDPKFBO);
		}
		if (LFGMMAPKDIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFGMMAPKDIC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyDailySettleScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eOBENDPKFBO_ != null)
		{
			if (eOBENDPKFBO_ == null)
			{
				EOBENDPKFBO = new ODONLHDAPKB();
			}
			EOBENDPKFBO.MergeFrom(other.EOBENDPKFBO);
		}
		if (other.LFGMMAPKDIC != 0)
		{
			LFGMMAPKDIC = other.LFGMMAPKDIC;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				if (eOBENDPKFBO_ == null)
				{
					EOBENDPKFBO = new ODONLHDAPKB();
				}
				input.ReadMessage(EOBENDPKFBO);
				break;
			case 120u:
				LFGMMAPKDIC = input.ReadUInt32();
				break;
			}
		}
	}
}
