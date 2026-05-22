using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournWeekChallengeUpdateScNotify : IMessage<RogueTournWeekChallengeUpdateScNotify>, IMessage, IEquatable<RogueTournWeekChallengeUpdateScNotify>, IDeepCloneable<RogueTournWeekChallengeUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueTournWeekChallengeUpdateScNotify> _parser = new MessageParser<RogueTournWeekChallengeUpdateScNotify>(() => new RogueTournWeekChallengeUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int IANMKEGOGMGFieldNumber = 1;

	private DPHNLKIPDGJ iANMKEGOGMG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournWeekChallengeUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournWeekChallengeUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHNLKIPDGJ IANMKEGOGMG
	{
		get
		{
			return iANMKEGOGMG_;
		}
		set
		{
			iANMKEGOGMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournWeekChallengeUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournWeekChallengeUpdateScNotify(RogueTournWeekChallengeUpdateScNotify other)
		: this()
	{
		iANMKEGOGMG_ = ((other.iANMKEGOGMG_ != null) ? other.iANMKEGOGMG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournWeekChallengeUpdateScNotify Clone()
	{
		return new RogueTournWeekChallengeUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournWeekChallengeUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournWeekChallengeUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IANMKEGOGMG, other.IANMKEGOGMG))
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
		if (iANMKEGOGMG_ != null)
		{
			num ^= IANMKEGOGMG.GetHashCode();
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
		if (iANMKEGOGMG_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(IANMKEGOGMG);
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
		if (iANMKEGOGMG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IANMKEGOGMG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournWeekChallengeUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iANMKEGOGMG_ != null)
		{
			if (iANMKEGOGMG_ == null)
			{
				IANMKEGOGMG = new DPHNLKIPDGJ();
			}
			IANMKEGOGMG.MergeFrom(other.IANMKEGOGMG);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iANMKEGOGMG_ == null)
			{
				IANMKEGOGMG = new DPHNLKIPDGJ();
			}
			input.ReadMessage(IANMKEGOGMG);
		}
	}
}
